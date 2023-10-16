let cartList = [];
function AddTocart(index, pname, price, image,qty) {
	

	let f = cartList.some(a => a.index == index);
	if (f) {
		cartList = cartList.filter(function (item) {
			qty += qty;
			return (item.price *= qty, item.qty = qty, item.name = item.name, item.image = item.image);
		});
	} else {
		cartList.push({"qty":qty, "index": index, "name": pname, "price": price, "image": image });

	}
	
	
	displaycart();
	
}
function displaycart() {
	let total = 0;
	let count = 0;
	let item = "";
	if (cartList.length > 0) {
		for (let i = 0; i < cartList.length; i++) {

			count = i;
			total += cartList[i].price;
			item += `<a class="dropdown-item"  >
			<div class="d-flex align-items-center" >
												<div class="flex-grow-1">
																<h6 class="cart-product-title">${cartList[i].pname}</h6>
																<p class="cart-product-price"> ${cartList[i].qty} -   ${cartList[i].price}</p>
															</div>
															<div class="position-relative">
																<div class="cart-product-cancel position-absolute">
														
																</div>
																<div class="cart-product">
																	<img style="height: 47px" src=${cartList[i].image} class="" alt="product image">
																</div>
															</div>
														</div >
														<a id="clear-cart" onclick='deletex(${cartList[i].index})' class="btn btn-primary">	<i class='bx bx-x'>delete</i></a>
													</a > `;
			$("#cart-count").html(count + "ITEMS");
			$(".alert-count").html(count);
		}
	}
	$("#total").html(total);
	$(".cart-list").html(item);
}
//<a id="clear-cart" value=${cartList[i].index}>
function deletex(data) {
	cartList = cartList.filter(function (item) {
		console.log("item index " + typeof (item.index) + "  data  " + typeof (data));
		return item.index !== data
	});
	
	displaycart();
	
}

	
