<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="_3_7_2024.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <section class="vh-100" style="background-color: #2779e2;">
  <div class="container h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-xl-9">

          
        <div class="card" style="border-radius: 15px;">
          <div class="card-body">

            <div class="row align-items-center pt-4 pb-3">
              <div class="col-md-3 ps-5">

                <h6 class="mb-0">Full name</h6>

              </div>
              <div class="col-md-9 pe-5">
                  <asp:TextBox ID="TextBox1" runat="server"  class="form-control form-control-lg"></asp:TextBox>
               

              </div>
            </div>

            <hr class="mx-n3">

            <div class="row align-items-center py-3">
              <div class="col-md-3 ps-5">

                <h6 class="mb-0">Email address</h6>

              </div>

              <div class="col-md-9 pe-5">

                <asp:TextBox ID="TextBox2" runat="server"  class="form-control form-control-lg"></asp:TextBox>

              </div>
            </div>

            <hr class="mx-n3">
              <div class="row align-items-center pt-4 pb-3">
  <div class="col-md-3 ps-5">

    <h6 class="mb-0">ID</h6>

  </div>
  <div class="col-md-9 pe-5">
   <asp:TextBox ID="TextBox3" runat="server"  class="form-control form-control-lg"></asp:TextBox>

  </div>
</div>

<hr class="mx-n3">
              
                <div class="d-md-flex justify-content-start align-items-center mb-4 py-2">

                  <h6 class="mb-0 me-4">Gender: </h6>

                  <div class="form-check form-check-inline mb-0 me-4">
                      <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Female" />
                      
                   
                    
                  </div>

                  <div class="form-check form-check-inline mb-0 me-4">
                      <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
                    
                  </div>


                </div>

              <hr class="mx-n3">

              
                <div class="d-md-flex justify-content-start align-items-center mb-4 py-2">

                  <h6 class="mb-0 me-4">Courses: </h6>

                  <div class="form-check form-check-inline mb-0 me-4">
                   
                      <asp:CheckBox ID="CheckBox1" runat="server" Text="C" OnCheckedChanged="CheckBox_checkedChanged" />
                    
                  </div>

                  <div class="form-check form-check-inline mb-0 me-4">
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="C#" OnCheckedChanged="CheckBox_checkedChanged" />

                  </div>

                  <div class="form-check form-check-inline mb-0">
                   <asp:CheckBox ID="CheckBox3" runat="server" Text="C++" OnCheckedChanged="CheckBox_checkedChanged" />

                  </div>

                </div>

            <div class="row align-items-center py-3">
              <div class="col-md-3 ps-5">

                <h6 class="mb-0">Description</h6>

              </div>
              <div class="col-md-9 pe-5">
                  <asp:TextBox ID="TextArea1" cols="20" rows="2" runat="server"></asp:TextBox>
                

              </div>
            </div>

            <hr class="mx-n3">

             

              </div>
            </div>

            <hr class="mx-n3">
          <asp:Button runat="server" Text="Submit" OnClick="Unnamed1_Click" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg"></asp:Button>

            <div class="px-5 py-4">
         
    </div>

          </div>
        </div>

      </div>
    </div>
  </div>
</section>
        </div>

        <br />
        <hr /> 

        <div>
            <h1>Name:</h1>
            
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            <h1>Email:</h1>
              <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <h1>ID:</h1>
  <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                      <h1>Gender:</h1>
<asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                                  <h1>Courses:</h1>
<asp:Label ID="Label5" runat="server" Text=""></asp:Label>
<h1>Description:</h1>
 <asp:Label ID="Label6" runat="server" Text=""></asp:Label>




        </div>
    </form>
   
</body>
</html>
