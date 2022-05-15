const button = document.getElementById('butt');
var cv=document.getElementById("tag");
function callback(){
cv.innerHTML="Download the CV by clicking here";
cv.style.fontSize="20px";
}

button.addEventListener('mouseover',callback);
// button.removeEventListener('mouseover',callback);
var fullname=document.getElementById("fname");
var email=document.getElementById("email");
var mobile=document.getElementById("mobile");

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
fetch('https://api.github.com/users/mahek1618')
.then(response => response.json())
.then(data => gitData(data))
.catch(error => console.log(error))
function gitData(data){
var main=document.getElementById("projects");
var div=document.createElement("div");
div.innerHTML='Name:' + data.name+ '<br/> Location:' +data.location+'<br/> Profile:'+'<img src="'+data.avatar_url+'"/>';
main.appendChild(div);
}
 var submitted=document.getElementById("submitted");
  async function check_form() {
    await sleep( 3000 );
   submitted.innerHtml="Your Data is Stored";
submitted.innerHTML.style.fontSize='30px';
    // return false;
  }
// // const hireButton=document.getElementById("hire");
// document.addEventListener('click', showContactForm());
// function showContactForm()
// {
// await showingForm();
// };
// function showingForm(){
    
// }




// function getUserPromise {
//     const newUser = getUserFromApi(user)
  
//     return new Promise((resolve, reject) => {
//       if (user) {
//         resolve(user)
//       } else {
//         reject(new Error('No more new users!'))
//       }
//     })
//   }
