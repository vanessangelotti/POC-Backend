const contents = [
    {
        content: "C:\\Users\\vanessa.angelotti\\Documents\\Apowersoft\\MongoDB\\Uma alternativa aos bancos relacionais tradicionais\\alunos.json",
        collection: "alunos",
        idPolicy: "overwrite_with_same_id", //overwrite_with_same_id|always_insert_with_new_id|insert_with_new_id_if_id_exists|skip_documents_with_existing_id|abort_if_id_already_exists|drop_collection_first|log_errors
        //Use the transformer to customize the import result
        //transformer: (doc)=>{ //async (doc)=>{
        //   doc["importDate"]= new Date()
        //   return doc; //return null skips this doc
        //}
    }
];

mb.importContent({
    connection: "cosmospocvanessa",
    database: "pocvanessa",
    fromType: "file",
    batchSize: 2000,
    contents
})