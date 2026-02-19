import mysql from "mysql2";

const db = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "",
  database: "adatbazis_nev"
});

db.connect((err) => {
  if (err) {
    console.error("MySQL hiba:", err);
  } else {
    console.log("MySQL csatlakozva");
  }
});

export default db;
