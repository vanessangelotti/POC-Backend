db.alunos.update(
    {nome: "Flavio Silva"},
    {$set: {"nome": "Fernanda Nascimento" }},
    {multi: true}
)

db.alunos.update(
    {nome: "Flavia Falco", _id:  ObjectId("5fc040dbfe8c7c3980dd9db6")},
    {$set: {"data_nascimento": new Date(1977,9,8), nome: "Flavia Falco", curso:{ nome: "pintura", duração: "6 meses"}, }}
)

db.alunos.update(
    {nome: "Fernanda Nascimento", _id:  ObjectId("5fc0410dfe8c7c3980dd9db7")},
    {curso:[{ nome: "pintura", duração: "6 meses"},{nome: "musica", duração: "8 meses"}]}
)

