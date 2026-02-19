const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "",
  database: "nevnapok"
});

connection.connect((err) => {
  if (err) {
    console.error("DB hiba:", err);
  } else {
    console.log("MySQL csatlakozva");
  }
});

module.exports = connection;
