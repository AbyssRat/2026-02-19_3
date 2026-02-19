import { useState } from "react";
import api from "../services/api";

function NevKereses() {
  const [nev, setNev] = useState("");
  const [eredmeny, setEredmeny] = useState(null);

  const handleSearch = () => {
    api.get(`/nevnapok?nev=${nev}`)
      .then(res => setEredmeny(res.data))
      .catch(() => setEredmeny(null));
  };

  return (
    <div>
      <h2>Keresés név alapján</h2>
      <input
        type="text"
        placeholder="Add meg a nevet"
        value={nev}
        onChange={(e) => setNev(e.target.value)}
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

export default NevKereses;
