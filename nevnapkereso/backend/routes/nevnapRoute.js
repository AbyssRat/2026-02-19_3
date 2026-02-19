import express from "express";
import controller from "../controllers/nevnapController";
import { Router } from "express";

router.get("/", controller.getAllNevnap);
router.post("/", controller.addNevnap);

module.exports = router;
