import mysql from "mysql2";

const db = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "",
  database: "nevnapok",
  port: 3306,
});

db.connect((err) => {
  if (err) {
    console.error("MySQL hiba:", err);
  } else {
    console.log("MySQL csatlakozva");
  }
});

export default db;
