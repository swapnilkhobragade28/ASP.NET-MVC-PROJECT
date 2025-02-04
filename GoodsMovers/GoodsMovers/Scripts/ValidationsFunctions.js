//=================Homepage calculating charges===============================================================================================


    function calculateCharges() {
                if (document.getElementById('pickuppoint').value == "" || document.getElementById('deliverypoint').value == "" || document.getElementById('avgDistance').value == "") {
        alert("Please fill all field properly !!!");
                }
    else {

                    if (document.getElementById('pickuppoint').value != null && document.getElementById('deliverypoint').value != null && document.getElementById('avgDistance').value != null && document.getElementById('vehicleType').value == "Bike") {
        document.getElementById('charges').value = document.getElementById('avgDistance').value * 20;
                    }
    else if (document.getElementById('pickuppoint').value != null && document.getElementById('deliverypoint').value != null && document.getElementById('avgDistance').value != null && document.getElementById('vehicleType').value == "AutoRikshaw") {
        document.getElementById('charges').value = document.getElementById('avgDistance').value * 50;
                    }
    else if (document.getElementById('pickuppoint').value != null && document.getElementById('deliverypoint').value != null && document.getElementById('avgDistance').value != null && document.getElementById('vehicleType').value == "Truck") {
        document.getElementById('charges').value = document.getElementById('avgDistance').value * 100;
                    }
                }

            }



//=================Customer sign up validations===============================================================================================


function ValidationsForCustomer()
{

    var email = document.getElementById('txt_email').value;
    var name = document.getElementById('txt_name').value;
    var city = document.getElementById('txt_city').value;
    var phone = document.getElementById('txt_phone').value;
    var pass = document.getElementById('txt_pass').value;
    var repass = document.getElementById('txt_repass').value;

    if (email == "" || name == "" || city == "" || phone == "" || pass == "" || repass == "")
    {
        alert("All fields are mandatory !!!");
    }
    else if (phone.length != 10)
    {
        alert("Phone must have 10 digits !!!");
    }

    else if (pass.length < 8)
    {
        alert("Password must be 8 to 16 characters long !!!");
    }

    else if (pass.length > 16)
    {
        alert("Password must be 8 to 16 characters long !!!");
    }

    else if (pass != repass)
    {
        alert("ReEntered password does not match !!!");
    }
}






//=================Delivery person sign up validations===============================================================================================

    function ValidationsForDeliveryPerson() {
        let email = document.getElementById('txt_email').value;
    let name = document.getElementById('txt_name').value;
    let city = document.getElementById('drd_city').value;
    let phone = document.getElementById('txt_phone').value;
    let vehicletype = document.getElementById('drd_vehicletype').value;
    let vehicleno = document.getElementById('txt_vehicleno').value;
    let licenceno = document.getElementById('txt_licenceno').value;
    let password = document.getElementById('txt_pass').value;
    let repassword = document.getElementById('txt_repass').value;

    if (email == "" || name == "" || city == "" || phone == "" || vehicletype == "" || vehicleno == "" || licenceno == "" || password == "" || repassword == "") {
        alert("All fields are mandatory !!!");
                        }
    else if (phone.length != 10) {
        alert("Phone must have 10 digits !!!");
                        }

    else if (password.length < 8) {
        alert("Password must be 8 to 16 characters long !!!");
                        }

                        else if (password.length > 16) {
        alert("Password must be 8 to 16 characters long !!!");
                        }

    else if (pass != repassword) {
        alert("ReEntered password does not match !!!");
                        }
                    }



//=================Gettting dropdown selected value in city model field===============================================================================================


function getCustomerCity(input) {
    let city = document.getElementById('txt_city');
    city.value = input.value;
}



//=================Gettting dropdown selected value in city model field===============================================================================================

function getDeliveryPersonCity(input)
{
    var input2 = document.getElementById('txt_city');
    input2.value = input.value;
}



//=================Gettting dropdown selected value in vehicleType model field===============================================================================================

function getVehicleType(input1)
{
    var input2 = document.getElementById('vehicleTypeInput');
    input2.value = input1.value;
}




//=================Gettting password value in password model field===============================================================================================


function validationsForLogin()
{
    var user = document.getElementById('txt_username').value;
    var pass = document.getElementById('txt_password').value;

    if (user == "" || pass == "") {
        alert("All fields are mandatory !!!");
    }
}

//=================Gettting password value in password model field===============================================================================================

function getLoginPassword(input)
{
    let password = document.getElementById('txt_password');
    password.value = input.value;
}



