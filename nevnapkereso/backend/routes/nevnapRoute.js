const express = require("express");
const router = express.Router();
const controller = require("../controllers/nevnapController");

router.get("/", controller.getAllNevnap);
router.post("/", controller.addNevnap);

module.exports = router;
