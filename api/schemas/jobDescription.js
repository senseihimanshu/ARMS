const mongoose=require("mongoose");
const objectId=mongoose.Schema.Types.objectId;

module.exports={
    openingDate:{
     type:Date,
     required:true,
     default:Date.now
    },
    closingDate:{
    type:Date,
    required:true,
    },
    jdName:{
        type:String,
        
    },
    noOfApplicants:{
    type:Number,
    default:0
    },
    noOfVacancies:{
    type:Number,
    required:true,
    default:20
    },
    appliedFor:{
     type:String,
     required:true,
     enum:["intern","consultant1","consultant2","associate1","associate2","manager1","manager2"],
     default:"consultant1"
    },
    salary:{
     type:Number,
     minimum:5000,
     maximum:20000
    },
    skills:{
        type:String,
      },
    eligibilityCriteria:{
        type:String,
        default:"ALL CLEAR"
    },
     jobType:{
        type:String,
        required:true,
        enum:["full-time","part-time"]
    },
    location:{
        type:String,
        required:true
    },
    jobProfileDescription:{
        type:String,
        required:true
    }
}