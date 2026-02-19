import db from "../config/db.js";

const honapNevek = [
  "",
  "január", "február", "március", "április",
  "május", "június", "július", "augusztus",
  "szeptember", "október", "november", "december"
];

export const getNevnap = (req, res) => {
  const { nap, nev } = req.query;

  // 📅 1️⃣ Dátum alapú keresés
  if (nap) {
    const [ho, napSzam] = nap.split("-");

    if (!ho || !napSzam || isNaN(ho) || isNaN(napSzam)) {
      return res.status(400).json({ error: "Hibás dátum formátum! Pl: 4-30" });
    }

    const sql = "SELECT nev1, nev2 FROM nevnap WHERE ho = ? AND nap = ?";

    db.query(sql, [ho, napSzam], (err, result) => {
      if (err) return res.status(500).json(err);
      if (result.length === 0)
        return res.status(404).json({ error: "Nincs találat" });

      res.json({
        datum: `${honapNevek[ho]} ${napSzam}.`,
        nevnap1: result[0].nev1,
        nevnap2: result[0].nev2
      });
    });

    return;
  }

  // 🔎 2️⃣ Név alapú keresés
  if (nev) {
    const sql = `
      SELECT ho, nap, nev1, nev2 
      FROM nevnap 
      WHERE nev1 = ? OR nev2 = ?
    `;

    db.query(sql, [nev, nev], (err, result) => {
      if (err) return res.status(500).json(err);
      if (result.length === 0)
        return res.status(404).json({ error: "Nincs találat" });

      const adat = result[0];

      res.json({
        datum: `${honapNevek[adat.ho]} ${adat.nap}.`,
        nevnap1: adat.nev1,
        nevnap2: adat.nev2
      });
    });

    return;
  }

  // ❌ Ha nincs paraméter
  res.status(400).json({
    error: "Adj meg ?nap=ho-nap vagy ?nev=nevet paramétert"
  });
};
