function showInputForm(reservationId) {
    var RoomNameInput = document.getElementById('eRoomName-' + reservationId);
    var DateInput = document.getElementById('eDate-' + reservationId);
    var TimeInput = document.getElementById('eTime-' + reservationId);
    var OkeyButton = document.getElementById('eOkeyButton-' + reservationId);

    RoomNameInput.style.display = 'inline';
    DateInput.style.display = 'inline';
    TimeInput.style.display = 'inline';
    OkeyButton.style.display = 'inline';
}