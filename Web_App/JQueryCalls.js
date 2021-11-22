
function loadData() {
    $.get("https://localhost:44308/api/Volkswagen/api/Volkswagen", function (data) {
        alert("Data Loaded: " + data);
    });
}
