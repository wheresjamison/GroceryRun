mergeInto(LibraryManager.library, {
  CallJS: function (number) {
    console.log("Number from Unity: " + number);
    RecieveNumberFromUnity(number);
  },
});
