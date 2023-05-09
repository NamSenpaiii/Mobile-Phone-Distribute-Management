<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Trang chủ - Danh sách sản phẩm</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css" integrity="sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <style>
        td {
            vertical-align: middle;
        }
        img {
            max-height: 100px;
        }
    </style>
</head>
<body>

<div class="container">
    <div class="row justify-content-center">
        <div class="col col-md-10">
            <h3 class="my-4 text-center">Product List</h3>
            <div class="d-flex justify-content-between">
                <a class="btn btn-sm btn-secondary mb-4" href="add_product.php">Add Product</a>
                <a href="logout.php">Logout</a>
            </div>
            <?php
            include 'db\config.php';
            // Truy vấn cơ sở dữ liệu để lấy danh sách sản phẩm
            $sql = "SELECT * FROM products";
            $result = $conn->query($sql);
            $total = mysqli_num_rows($result); // get total number of rows in the result set

            // Hiển thị danh sách sản phẩm trong bảng HTML
            echo '<h3>Total Products: ' . $total . '</h3>'; // display total number of products
            echo '<table class="table-bordered table table-hover text-center">';
            echo '<tr>';
            echo '<th>Image</th>';
            echo '<th>Name</th>';
            echo '<th>Price</th>';
            echo '<th>Description</th>';
            echo '<th>Actions</th>';
            echo '</tr>';

            while ($row = mysqli_fetch_assoc($result)) {
                echo '<tr>';
                echo '<td class="align-middle"><img src="images/' . $row["Name"] . '.png"></td>';
                echo '<td class="align-middle">' . $row["Name"] . '</td>';
                echo '<td class="align-middle">' . $row["Price"] . '</td>';
                echo '<td class="align-middle">' . $row["Description"] . '</td>';
                echo '<td class="align-middle">';
                echo '<button class="btn btn-sm btn-primary mr-1 edit-btn"><i class="fas fa-pen"></i></button>';
                echo '<button class="btn btn-sm btn-danger delete-btn" data-id="' . $row["ProductID"] . '"><i class="fas fa-trash-alt"></i></button>';
                echo '</td>';
                echo '</tr>';
            }

            echo '</table>';
            ?>
        </div>
    </div>
</div>

    <!-- Delete Confirm Modal -->
    <div id="deleteModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <hp class="modal-title">Delete a Product</hp>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    <p>Are you sure you want to delete <strong>iPhone XS MAX</strong> ?</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-sm btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-sm btn-danger">Delete</button>
                </div>

            </div>

        </div>
    </div>


    <!-- Edit Confirm Modal -->
    <div id="editModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <hp class="modal-title">Update product <strong></strong></hp>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    <form>
                        <div class="form-group">
                            <label for="name">Product Name</label>
                            <input id="name" type="text" class="form-control">
                        </div>
                        <div class="form-group">
                            <label for="price">Price</label>
                            <input id="price" type="number" class="form-control">
                        </div>
                        <div class="form-group">
                            <label for="desc">Description</label>
                            <input id="desc" type="text" class="form-control">
                        </div>
                    </form>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-sm btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-sm btn-success">Save</button>
                </div>

            </div>
    
        </div>
    </div>

    <script>
    $(document).ready(function(){
        $('.delete-btn').on('click', function(){
            var id = $(this).data('id');
            var name = $(this).closest('tr').find('td:eq(1)').text(); // get the product name from the table row
            $('#deleteModal').find('.modal-body p strong').text(name);
            $('#deleteModal').modal('show');
            $('#deleteModal').find('.btn-danger').on('click', function(){
                $.ajax({
                    url: 'delete_product.php',
                    type: 'post',
                    data: { id: id },
                    success: function(){
                        window.location.reload();
                    },
                    error: function(){
                        alert('Error deleting product');
                    }
                });
            });
        });
    });
</script>
</body>
</html>