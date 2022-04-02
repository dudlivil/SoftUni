import * as api from './api.js'


const endpoints = {

    allPets: '/data/pets?sortBy=_createdOn%20desc&distinct=name',
    create : '/data/pets',
    petById : '/data/pets/',
    deleteById:'/data/pets/',
    update : '/data/pets/'

};


export async function getAllPets(){

    return api.get(endpoints.allPets);
}
 

export async function create(data){

    return api.post(endpoints.create,data);
}

export async function getById(id){

    return api.get(endpoints.petById+id);
}

export async function deleteById(id){

    return api.del(endpoints.deleteById +id)
}

export async function update(id,data){

    return api.put(endpoints.update+id,data)
}