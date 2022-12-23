

function mOut(obj) {
    obj.innerHTML = "22.000$";
}

function mOver(obj) {
    obj.innerHTML = "Mua";
}

function checkphone(obj) {
    var phone = document.getElementById('phoneNumber');
    var filter = /^[0-9-+]+$/;
    if (filter.test(phone) == false) {
        alert('Nhập sai số điện thoại');
    }
}