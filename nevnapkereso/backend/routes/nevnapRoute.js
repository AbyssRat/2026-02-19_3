import express from "express";
import { getAllNevnap, addNevnap } from "../controllers/nevnapController.js";

const nevnapRouter = express.Router();

nevnapRouter.get("/", getAllNevnap);
nevnapRouter.post("/", addNevnap);

export default nevnapRouter;
