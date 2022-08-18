function customConfirm() {
    return new Promise(resolve => {
        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            resolve(result.isConfirmed);
            {
                //if (result.isConfirmed) {
                //    Swal.fire(
                //        'Deleted!',
                //        //'Your file has been deleted.',
                //        data + ' has been deleted.',
                //        'success'
                //    )
                //}
            }
        })
    });
}

function success() {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Your work has been saved',
        showConfirmButton: false,
        timer: 1500
    })
}

function smallSuccess(message) {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 3000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'success',
        title: message
    })
}

function required(message) {
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: message,
        //footer: 'Please fill-up category!'
    })
}
