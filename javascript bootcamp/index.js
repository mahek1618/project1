
var style=document.createElement('style');



style.innerHTML=`

#container{

    background-color:beige;

    height:600px;

  width:550px;

  margin-left:30%;

    border:5px solid black;

  border-radius:10%;

  text-align:center;

}
`;
var fullname=document.getElementById("fname");
var email=document.getElementById("email");
var mobile=document.getElementById("mobile");
var password=document.getElementById("pass");
var Cpassword=document.getElementById("cpassword");
function FullNamevalidation()
{
      var fullnamevalid=fullname.value.trim();
      var validname=/^[A-Za-z]+$/;
      var nameErr=document.getElementById("NameTag");
      nameErr.style.color='red';
      if(fullnamevalid=="")
      {
nameErr.innerHTML="FullName is Required";
      }
      else if(!validname.test(fullnamevalid))
      nameErr.innerHTML="Enter valid Name";
 else{
     nameErr.innerHTML="";
     return true;
 }
};
fname.oninput= function()
{
    FullNamevalidation();
}
function emailvalidation()
{
      var emailvalid=email.value.trim();
      var validemail=/^\w+([\.-]?\w+)@\w+([\.-]?\w+)(\.\w{2,3})+$/;
      var mailErr=document.getElementById("MailTag");
      mailErr.style.color='red';
      if(emailvalid=="")
      {
mailErr.innerHTML="E-mail is Required";
      }
      else if(!validemail.test(emailvalid))
      mailErr.innerHTML="Enter valid E-mail Address";
 else{
     mailErr.innerHTML="";
     return true;
 }
};
email.oninput= function()
{
    emailvalidation();
}
function Mobilevalidation()
{
      var mobilevalid=mobile.value.trim();
      var validMobile=  /^\+?([0-9]{2})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$/;
      var mobileErr=document.getElementById("MobileTag");
      mobileErr.style.color='red';
      if(mobilevalid=="")
      {
mobileErr.innerHTML="Mobile Number is Required";
      }
      else if(!validMobile.test(mobilevalid))
      mobileErr.innerHTML="Please enter in the following way: +XX XXXX XXXX";
 else{
     mobileErr.innerHTML="";
     return true;
 }
};
mobile.oninput= function()
{
    Mobilevalidation();
}
function Passwordvalidation()
{
      var passvalid=password.value;
      var validpass= /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{8,15}$/;
      var passErr=document.getElementById("PassTag");
      passErr.style.color='red';
      if(passvalid=="")
      {
passErr.innerHTML="Password is Required";
      }
      else if(!validpass.test(passvalid))
      passErr.innerHTML="Password must have at least one Uppercase, lowercase, digit, special characters & 8 characters";
 else{
     passErr.innerHTML="";
     return true;
 }
};
pass.oninput= function()
{
    Passwordvalidation();
}
function ConfirmPasswordvalidation()
{
      var validpasscall=Passwordvalidation();
      var Conpassvalid=Cpassword.value;
      var ConpassErr=document.getElementById("CpassTag");
      ConpassErr.style.color="red";
      if(validpasscall==true)
      {
          var pass=password.value;
        if(Conpassvalid=="")
        ConpassErr.innerHTML="Confirmed Password is Required";
         else if(password.value != Conpassvalid)
          ConpassErr.innerHTML="Password does not Match";
        else{
            ConpassErr.innerHTML="";
            return true;
        }
      }
    };

//       var validpass= /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{8,15}$/;
//       var passErr=document.getElementById("PassTag");
//       passErr.style.color='red';
//       if(passvalid=="")
//       {
// passErr.innerHTML="Password is Required";
//       }
//       else if(!validpass.test(passvalid))
//       passErr.innerHTML="Password must have at least one Uppercase, lowercase, digit, special characters & 8 characters";
//  else{
//      passErr.innerHTML="";
//      return true;
//  }
// };
cpassword.oninput= function()
{
   debugger
    ConfirmPasswordvalidation();
    // var rehat =2;
}

