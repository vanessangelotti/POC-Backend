db.alunos.find({
    "curso.nome": "Moda Especializado"
})

db.alunos.find({
    "habilidade.nivel": "avançado"
    
})

db.alunos.find({
    "nome": {$regex: "Angelotti"}
})
.sort({"data_nascimento": 1})

db.alunos.find({
    "curso.nome": "Matemática",
     "notas": {$gt: 9}
})

db.alunos.find({
    "notas": 6.6
    
})

db.alunos.find({
    "notas": {$lt: 3 }
})

db.alunos.find({
    "notas": {$gt: 3 }
})

db.alunos.find({
    "notas": {$eq: 9 }
})

db.alunos.findOne({
    notas: {$eq: 9}
}).sort({"nome": 1})

db.alunos.find({
    notas: {$eq: 9}
})
.sort({nome: -1})
.limit(1)

db.alunos.find({
    notas: {$eq: 9}
})
.sort({nome: 1})
.limit(1)

db.alunos.find({})