import express from "express";
import cors from "cors";
import nevnapRoutes from "./routes/nevnapRoutes.js";

const app = express();

app.use(cors());
app.use(express.json());

app.use("/api/nevnap", nevnapRoutes);

app.listen(5000, () => {
  console.log("Szerver fut a http://localhost:5000 címen");
});
