import mysql from "mysql";

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

export default connection;
