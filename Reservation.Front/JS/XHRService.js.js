  function get(address) {
    alert('Internal')
    var xhr = new XMLHttpRequest();
    xhr.withCredentials = true;

    xhr.addEventListener("readystatechange", function () {
        if (this.readyState === 4) {
            var res = JSON.parse(this.responseText);
        }
    });

    xhr.open("GET", address);

    xhr.send();

}
