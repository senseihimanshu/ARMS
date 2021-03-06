const decoder = require('./tokenDecoder');

class RoleChecker{
    constructor(){

    }

    checkForAdmin(req, res, next){
        let role = decoder(req.header('Authorization')).role;
        if(role == "Admin"){
            next();
        }
        else{
            return res.status(401).send({
                success: false,
                payload: {
                    message: "You are not authorized to make this request"
                }
            });
        }
    }
}

module.exports = new RoleChecker();