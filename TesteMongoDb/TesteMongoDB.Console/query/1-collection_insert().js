db.alunos.insert({
    nome: "Flavio Silva",
    data_nascimento: new Date("1982-08-15T00:00:00Z -03:00") ,
    curso: {
        nome: "Corte e Costura",
        duração: "5 anos"
    },
    notas: [8,4,2],
    habilidade: [{
        nome: "Espanhol",
        nivel: "Avançado"
    }]
})


db.getCollection("alunos").createIndex({ "nota": 1 ,"curso": 1})
db.getCollection("alunos").createIndex({"data_nascimento": -1})