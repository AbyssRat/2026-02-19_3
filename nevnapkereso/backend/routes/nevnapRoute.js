import express from "express";
import { getAllNevnap, addNevnap } from "../controllers/nevnapController.js";

const router = express.Router();

router.get("/", getAllNevnap);
router.post("/", addNevnap);

export default router;
