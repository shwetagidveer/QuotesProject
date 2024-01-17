function addNewWEField() {

    //Adding New Work Experience
    // Create a new textarea element
    let newNode = document.createElement("textarea");
    newNode.classList.add("form-control");
    newNode.classList.add("weField");
    newNode.classList.add("mt-2");
    newNode.setAttribute("rows", 2);
    newNode.setAttribute("placeholder", "Enter Your Work Experience");

    // Find the parent node where the new node will be inserted
    let weOb = document.getElementById("we");

    // Insert the new node before the last child of the parent node
    weOb.insertBefore(newNode, weOb.lastElementChild);
}

function addNewAQField(){

    //Adding New Academic ualifications
    let newNode = document.createElement("textarea");
    newNode.classList.add("form-control");
    newNode.classList.add("aqField");
    newNode.classList.add("mt-2");
    newNode.setAttribute("rows", 2);
    newNode.setAttribute("placeholder", "Enter Your Academic Qualifications");

    // Find the parent node where the new node will be inserted
    let aqOb = document.getElementById("aq");

    // Insert the new node before the last child of the parent node
    aqOb.insertBefore(newNode, aqOb.lastElementChild);
}

function addNewEAField() {
    // Adding New Extra Activities
    let newNode = document.createElement("textarea");
    newNode.classList.add("form-control");
    newNode.classList.add("eaField");
    newNode.classList.add("mt-2");
    newNode.setAttribute("rows", 2);
    newNode.setAttribute("placeholder", "Enter Your Extra Activities");

    let extraActivitiesOb = document.getElementById("ea");
    extraActivitiesOb.insertBefore(newNode, extraActivitiesOb.lastElementChild);
}

function addNewHBField() {
    // Adding New Hobbies
    let newNode = document.createElement("textarea");
    newNode.classList.add("form-control");
    newNode.classList.add("hobbiesField");
    newNode.classList.add("mt-2");
    newNode.setAttribute("rows", 2);
    newNode.setAttribute("placeholder", "Enter Your Hobbies");

    let hobbiesOb = document.getElementById("hb");
    hobbiesOb.insertBefore(newNode, hobbiesOb.lastElementChild);
}

// function validateForm() {
//     let nameField = document.getElementById("nameField").value;
//     let contactField = document.getElementById("contactField").value;
//     let emailField = document.getElementById("emailField").value;
//     let githubField = document.getElementById("githubField").value;
//     let linkedinField = document.getElementById("linkedinField").value;
//     let websiteField = document.getElementById("websiteField").value;
//     let objectiveField = document.getElementById("objectiveField");
//     let hobbiesField = document.getElementById("hobbiesField");

//     if (nameField.trim() === "") {
//         alert("Please Enter Your Name");
//         return false;
//     }
//     if (!isValidAlphabets(nameField)) {
//         alert("Please Enter a Valid Name with only Alphabets");
//         return false;
//     }   

//     if (contactField.trim() === "") {
//         alert("Please Enter Your Contact Number");
//         return false;
//     }
//     if (!isValidNumeric(contactField)) {
//         alert("Please Enter a Valid Contact Number with only Numeric Values");
//         return false;
//     }
    
//     if (emailField.trim() === "") {
//         alert("Please Enter Your Email Address");
//         return false;
//     }
//     if (!isValidEmail(emailField)) {
//         alert("Please Enter a Valid Email Address");
//         return false;
//     }

//     if (!objectiveField || objectiveField.value.trim() === "") {
//         alert("Please Enter Your Objectives");
//         return false;
//     }
//     if (!isValidAlphabets(objectiveField.value)) {
//         alert("Please Enter a Valid Objectives");
//         return false;
//     }

//     if (!hobbiesField || hobbiesField.value.trim() === "") {
//         alert("Please Enter Your Hobbies");
//         return false;
//     }
//     if (!isValidAlphabets(hobbiesField.value)) {
//         alert("Please Enter a Valid Hobbies");
//         return false;
//     }

//     if (githubField.trim() !== "" && !isValidGitHub(githubField)) {
//         alert("Please enter a valid GitHub username");
//         return false;
//     }

//     if (linkedinField.trim() !== "" && !isValidLinkedIn(linkedinField)) {
//         alert("Please enter a valid LinkedIn profile URL");
//         return false;
//     }

//     if (websiteField.trim() !== "" && !isValidWebsite(websiteField)) {
//         alert("Please enter a valid website URL");
//         return false;
//     }
//     // Add more validation for other fields as needed

//     return true; // If all validations pass
// }
// function isValidAlphabets(input) {
//     // Regular expression to check if the input contains only alphabets
//     const alphabetRegex = /^[A-Za-z]+$/;

//     return alphabetRegex.test(input);
// }
// function isValidNumeric(input) {
//     // Regular expression to check if the input contains only numeric values
//     const numericRegex = /^[0-9]+$/;

//     return numericRegex.test(input);
// }
// function isValidEmail(input) {
//     // Regular expression to check if the input is a valid email address
//     const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
//     return emailRegex.test(input);
// }
// function isValidGitHub(input) {
//     // Regular expression to check if the input is a valid GitHub username
//     const githubRegex = /^[a-zA-Z\d](?:[a-zA-Z\d]|-(?=[a-zA-Z\d])){0,38}$/;
//     return githubRegex.test(input);
// }

// function isValidLinkedIn(input) {
//     // Regular expression to check if the input is a valid LinkedIn profile URL
//     const linkedinRegex = /^(https?:\/\/)?(www\.)?linkedin\.com\/in\/[a-zA-Z0-9_-]+\/?$/;
//     return linkedinRegex.test(input);
// }

// function isValidWebsite(input) {
//     // Regular expression to check if the input is a valid website URL
//     const websiteRegex = /^(https?:\/\/)?([a-zA-Z\d.-]+)\.([a-zA-Z]{2,})(\/[^\s]*)?$/;
//     return websiteRegex.test(input);
// }


function generateCV(){

    //Generating Cv
    //console.log("Generating CV")

    // if (validateForm()) {

    let nameField = document.getElementById("nameField").value;
    let nameT1 = document.getElementById("nameT1");
    nameT1.innerHTML = nameField;

    //Fetching Records in Resume
    document.getElementById("nameT2").innerHTML = nameField;
    document.getElementById("contactT").innerHTML = document.getElementById("contactField").value;
    document.getElementById("addressT").innerHTML = document.getElementById("addressField").value;
    document.getElementById("emailT").innerHTML = document.getElementById("emailField").value;    
    document.getElementById("linkedinT").innerHTML = document.getElementById("linkedinField").value;
    document.getElementById("githubT").innerHTML = document.getElementById("githubField").value;
    document.getElementById("websiteT").innerHTML = document.getElementById("websiteField").value;
    document.getElementById("objectiveT").innerHTML = document.getElementById("objectiveField").value;

    // Work Experience
        let wes = document.getElementsByClassName("weField");
        let str = " ";
        for(let e of wes)
        {
            str = str + `<li>${e.value}</li>`
        }
     document.getElementById("weT").innerHTML = str;

        // Academic Qualification
        let aqs = document.getElementsByClassName("aqField");
        let str1 = " ";
        for(let a of aqs)
        {
            str1 = str1 + `<li>${a.value}</li>`
        }
     document.getElementById("aqT").innerHTML = str1;

        // Extra Activities
        let extraActivities = document.getElementsByClassName("eaField");
        let str2 = " ";
        for (let ea of extraActivities) {
            str2 = str2 + `<li>${ea.value}</li>`;
        }
        document.getElementById("acepcT").innerHTML = str2;

        // Hobbies
        let hobbies = document.getElementsByClassName("hobbiesField");
        let str3 = " ";
        for (let h of hobbies) {
            str3 = str3 + `<li>${h.value}</li>`;
        }
        document.getElementById("hobbiesT").innerHTML = str3;


        // document.getElementById("cv-form").style.display = 'none';
        document.getElementById("cv-template").style.display = 'block';
   }
//}

function printCV(){
    //Printing CV
    window.print();
}