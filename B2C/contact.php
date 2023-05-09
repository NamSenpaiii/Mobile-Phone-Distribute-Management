<!DOCTYPE html>
<html>
<head>
	<title>contact Us</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="font-awesome/css/all.min.css">
    <link rel="stylesheet" type="text/css" href="home.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
</head>
<body>
<header>
        <nav class="navbar navbar-expand-lg navbar-light" style="background-color: #E0052B;">
            <div class="container-fluid">
            <a class="navbar-brand" href="home.php">
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
                        <a class="nav-link" style="color: #FFFFFF;" href="products.php">Sản phẩm</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" style="color: #FFFFFF;" href="contact.php">Liên hệ</a>
                    </li>
                </ul>
            </div>
            <form class="d-flex">
            <form class="d-flex">
                <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search" id="search-input">
                <div id="search-results"></div>
            </form>
            <ul class="navbar-nav ml-auto" id="">
                <li class="nav-item">
                    <a class="nav-link" style="color: #FFFFFF;" href="cart.php">
                        <i class="fa-solid fa-truck"></i></i></i>Tra cứu đơn hàng 
                    </a>
                </li>
            </ul>
            <ul class="navbar-nav ml-auto">
                <li class="nav-item">
                    <a class="nav-link" style="color: #FFFFFF;" href="cart.php">
                        <i class="fas fa-shopping-cart mr-2"></i>Giỏ hàng 
                    </a>
                </li>
            </ul>
            <ul class="navbar-nav ml-auto">
                <li class="nav-item">
                    <a class="nav-link btn logout-button" style="color: #FFFFFF;" href="logout.php">
                        <i class="fas fa-sign-out-alt mr-2 logout-icon"></i> Logout
                    </a>
                </li>
            </ul>
            </div>
        </nav>
    </header>
    
	<main role="main" class="container">
        <h2>Liên hệ với chúng tôi</h2>
        <form action="#" method="POST">
            <label for="name">Name: Nam Phát Mobile</label>
            <input type="text" id="name" name="name" required>

            <label for="email">Email:nguyenthanhphat3333@gmail.com</label>
            <input type="email" id="email" name="email" required>

            <label for="subject">Subject:CNTT</label>
            <input type="text" id="subject" name="subject" required>
        </form>
    </main>
	
	</main>

	<footer class="container">
		<p>Bản quyền &copy; 2023 - Nam Phát Mobile</p>
	</footer>
    
</body>
</html>
