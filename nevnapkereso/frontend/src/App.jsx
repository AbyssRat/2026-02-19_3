import MaiNevnap from "./components/MaiNevnap";
import NevKereses from "./components/NevKereses";
import DatumKereses from "./components/DatumKereses";
import "./App.css";

function App() {
  return (
    <div className="container">
      <h1>Névnap kereső</h1>

      <div className="card">
        <MaiNevnap />
      </div>

      <div className="card">
        <NevKereses />
      </div>

      <div className="card">
        <DatumKereses />
      </div>
    </div>
  );
}

export default App;
