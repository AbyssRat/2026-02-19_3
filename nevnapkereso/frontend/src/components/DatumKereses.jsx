import { useState } from "react";
import api from "../services/api";

function DatumKereses() {
  const [datum, setDatum] = useState("");
  const [eredmeny, setEredmeny] = useState(null);

  const handleSearch = () => {
    api.get(`/nevnapok?nap=${datum}`)
      .then(res => setEredmeny(res.data))
      .catch(() => setEredmeny(null));
  };

  return (
    <div>
      <h2>Keresés dátum alapján</h2>
      <input
        type="text"
        placeholder="Pl: 4-30"
        value={datum}
        onChange={(e) => setDatum(e.target.value)}
      />
      <button onClick={handleSearch}>Keres</button>

      {eredmeny && (
        <p>
          {eredmeny.datum} – {eredmeny.nevnap1} {eredmeny.nevnap2 && `és ${eredmeny.nevnap2}`}
        </p>
      )}
    </div>
  );
}

export default DatumKereses;
