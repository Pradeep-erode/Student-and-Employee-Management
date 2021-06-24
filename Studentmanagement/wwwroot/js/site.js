 //please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

 //write your javascript code.


    function submitdetails() {
        if ($("#formvalia").validate()) {
        $("#formvalia").submit();
        }
    }
    $(function () {
        $("#formvalia").validate({
            rules: {
                name:
                {
                    required: true
                },
                mail:
                {
                    required: true,
                },
                StudentDepartment:
                {
                    required: true
                },
                Gender:
                {
                    required: true
                }
            },
            messages:
            {
                name:
                {
                    required: "Name is required"
                },
                mail:
                {
                    required: "Mail is required"
                },
                StudentDepartment:
                {
                    required: "Department is required"
                },
                Gender:
                {
                    required: "Please select gender"
                }
            }
        });
    });
