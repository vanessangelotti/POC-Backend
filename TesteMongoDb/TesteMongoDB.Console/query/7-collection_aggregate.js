db.alunos.aggregate([{
  $geoNear:{
      near:{
	        coordinates : [-23.5640265,-46.6527128],
	        type : "Point"
      },
      distanceField: "distancia.calculada",
      spherical: true,
      key: "localizacao",
  }  
},
{
    $skip: 1
}
])
.limit(5)
