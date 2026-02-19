import connection from "../config/db";

exports.getAllNevnap = (req, res) => {
  db.query("SELECT * FROM nevnap", (err, result) => {
    if (err) return res.status(500).json(err);
    res.json(result);
  });
};

exports.addNevnap = (req, res) => {
  const { nev1, nev2, ho, nap } = req.body;

  const sql = "INSERT INTO nevnap (nev1, nev2, ho, nap) VALUES (?, ?, ?, ?)";
  db.query(sql, [nev1, nev2, ho, nap], (err, result) => {
    if (err) return res.status(500).json(err);
    res.json({ message: "Sikeres mentés" });
  });
};
