import express from "express";
import { getNevnap } from "../controllers/nevnapController.js";

const nevnapRouter = express.Router();

nevnapRouter.get("/", getNevnap);



export default nevnapRouter;
