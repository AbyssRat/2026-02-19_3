import { useEffect, useState } from "react";
import api from "../services/api";

function MaiNevnap() {
  const [adat, setAdat] = useState(null);

  useEffect(() => {
    const today = new Date();
    const ho = today.getMonth() + 1;
    const nap = today.getDate();

    api.get(`/nevnapok?nap=${ho}-${nap}`)
      .then(res => setAdat(res.data))
      .catch(() => setAdat(null));
  }, []);

  return (
    <div>
      <h2>Mai névnap</h2>
      {adat ? (
        <p>
          {adat.datum} – {adat.nevnap1} {adat.nevnap2 && `és ${adat.nevnap2}`}
        </p>
      ) : (
        <p>Nincs adat.</p>
      )}
    </div>
  );
}

export default MaiNevnap;
