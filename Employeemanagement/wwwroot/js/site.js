// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function SubmitDetails() {
    if ($("#formvalidate").validate()) {
        $("#formvalidate").submit();
    }
}
$(function () {
        $("#formvalidate").validate({
            rules: {
                fullname:
                {
                    required: true,
                },
                username:
                {
                    required: true

                },
                Email:
                {
                    required: true
                },
                department:
                {
                    required: true
                },
                work:
                {
                    required: true

                },
                address:
                {
                    required: true
                },
                phonenumber:
                {
                    required: true,
                    minlength: 10,
                    maxlength: 10
                    
                },
                gender:
                {
                    required: true
                }
            },
            messages:
            {
                fullname:
                {
                    required: "Name is required"
                },
                username:
                {
                    required: "Username required"
                },
                Email:
                {
                    required: "Mail is required"
                },
                department:
                {
                    required: "StudentDepartment is required"
                },
                work:
                {
                    required: "Work is required"
                },
                address:
                {
                    required: "Address is required"
                },
                phonenumber:
                {
                    required: "Phone number is required",
                    minlength: "Minimum 10 digit is required",
                    maxlength:"Maximum 10 digit only"
                },
                gender:
                {
                    required: "Gender is required"
                }
            }
        });
    });
   