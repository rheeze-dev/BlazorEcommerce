function customConfirm(data) {
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
                if (result.isConfirmed) {
                    Swal.fire(
                        'Deleted!',
                        //'Your file has been deleted.',
                        data + ' has been deleted.',
                        'success'
                    )
                }
            }
        })
    });
}