const express = require("express");
const { fucaoSimples } = require("./funcaoSimples");
const app = express();
const PORT = 3000;

app.get("/", function (req, res) {
  const response = fucaoSimples(2, 2);
  res.send(`${response}`);
});

console.log(`Servidor funcionando na porta ${PORT}`);

app.listen(PORT);
