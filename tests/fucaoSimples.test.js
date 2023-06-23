const { fucaoSimples } = require("../funcaoSimples");

test("Teste fucaoSimples deve ser executado corretamente", () => {
  const resultado = fucaoSimples(5, 5);

  expect(resultado).toBe(10);
});
