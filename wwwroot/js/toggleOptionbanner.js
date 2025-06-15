

function ToggleOptionBar() {
    var selector = $(this).data("target");
    $(selector).toggleClass("in");

    var options = document.querySelector(".data");
    options.classList.toggle("in");
}

$("[data-toggle='toggle']").click(ToggleOptionBar);