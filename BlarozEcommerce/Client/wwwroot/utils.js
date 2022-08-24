function hide() {
    const actionButtons = document.querySelectorAll('.actionButtons');
    const addButton = document.querySelector('.addButton');

    [].forEach.call(actionButtons, function (addClass) {
        addClass.classList.add('hidden');
    });
        addButton.classList.add('hidden');
}

function show() {
    const actionButtons = document.querySelectorAll('.actionButtons');
    const addButton = document.querySelector('.addButton');

    [].forEach.call(actionButtons, function (removeClass) {
        removeClass.classList.remove('hidden');
    });
    addButton.classList.remove('hidden');
}

//function myFunction() {
//    document.querySelectorAll('.response').style.display = "none";
//}

function hideDeleteButton() {
    //document.querySelector('.removeVariant').classList.add('hidden');
    //document.querySelector('.removeVariant').style.visibility = "hidden";
    //document.getElementById("myH1").style.visibility = "hidden";

    const removeVariantButton = document.querySelectorAll('.removeVariant');

    [].forEach.call(removeVariantButton, function (addClass) {
        addClass.classList.add('hidden');
    });
}
