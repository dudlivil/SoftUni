import {clearUserData,getAccessToken} from '../util.js';

const host = 'http://localhost:3030';

async function request(method,url,data){

    const options ={
        method,
        headers:{}
    };

    const token = getAccessToken();

    if(token){

        options.headers['X-Authorization'] = token ;
    }

    if(data){

        options.headers['Content-Type'] = 'aplication/json';
        options.body = JSON.stringify(data);
    }


    try {

        const response = await fetch(host + url, options);
        if(response.ok !=true){

            if(response.status == 403){

                clearUserData();
            }

            const error = await response.json();
            throw new Error(error.message);
        }

        if(response.status == 204){

            return response;
        }else{

            return response.json();
        }
    }catch(err){

        alert(err.message);
        throw err;
    }
}


export const get=request.bind(null,'GET');
export const post=request.bind(null,'POST');
export const put=request.bind(null,'PUT');
export const del=request.bind(null,'DELETE');
export const patch=request.bind(null,'PATCH');