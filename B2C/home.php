

<!DOCTYPE html>
<html>
<head>
	<title>Khung PHP với Bootstrap</title>
	<!-- Thêm tệp CSS của Bootstrap -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="home.css">
</head>
<body>
	<header>
        <nav class="navbar navbar-expand-lg navbar-light" style="background-color: #E0052B;">
            <a class="navbar-brand" href="http://localhost/testfinalcnpm2/home.php">
                <img src="images\CellphoneS.png" alt="logo cellphoneS" width="161" height="36">
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item active">
                        <a class="nav-link" style="color: #FFFFFF;" aria-current="page" href="home.php">Trang chủ</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" style="color: #FFFFFF;" href="#">Sản phẩm</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" style="color: #FFFFFF;" href="#">Liên hệ</a>
                    </li>
                </ul>
            </div>
            <div class="d-flex justify-content-center navbar-form">
                <form class="form-inline">
                    <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search">
                    <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
                </form>
            </div>
        </nav>
    </header>
	<main role="main" class="container">
        <div class="main">
            <img src="images\khai-truong-th4-sliding-55.webp" alt="logo cellphoneS">
        </div>
        <?php
            include 'db\config.php';
            // Truy vấn dữ liệu từ bảng Products
            $sql = "SELECT * FROM products";
            $result = $conn->query($sql);

            // Tạo các ô sản phẩm tương ứng với dữ liệu từ bảng Products
            if ($result->num_rows > 0) {
                echo '<div class="container">';
                echo '<div class="row">';
                while($row = $result->fetch_assoc()) {
                    echo '<div class="col-md-4">';
                    echo '<div class="card">';
                    echo '<img class="card-img-top" src="images/' . $row["Name"] . '.png" alt="' . $row["Name"] . '">';
                    echo '<div class="card-body">';
                    echo '<h4 class="card-title">' . $row["Name"] . '</h4>';
                    echo '<p class="card-text">' . $row["Description"] . '</p>';
                    echo '<div class="d-flex justify-content-between align-items-center">';
                    echo '<div class="btn-group">';
                    echo '<button type="button" class="btn btn-sm btn-outline-secondary">Thêm vào giỏ hàng</button>';
                    echo '<button type="button" class="btn btn-sm btn-outline-secondary">Mua ngay</button>';
                    echo '</div>';
                    echo '<small class="text-muted price">Giá: $' . $row["Price"] . '</small>';
                    echo '</div>';
                    echo '</div>';
                    echo '</div>';
                    echo '</div>';
                }
                echo '</div>';
                echo '</div>';
            } else {
                echo "Không có sản phẩm nào.";
            }

            $conn->close();
        ?>
	</div>
	</main>

	<footer class="container">
		<p>Bản quyền &copy; 2023 - Tên công ty của bạn</p>
	</footer>

	<!-- Thêm tệp JavaScript của Bootstrap -->
	<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
</body>
</html>
