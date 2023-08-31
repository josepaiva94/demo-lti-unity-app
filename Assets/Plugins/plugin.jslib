var ltiJS = {
  $dependencies:{},
  GetLtiUsername: async function ()
  {
    try {
      const userData = await getLtiUserData();
      if (userData) {
        // Call the callback function with the username
        unityInstance.SendMessage('baseGameObject', 'SetLtiUsername', userData.name);
      }
      else {
        // Call the callback function with the username
        unityInstance.SendMessage('baseGameObject', 'SetLtiUsername', 'anonymous');
      }
    } catch (err) {
      // Call the callback function with the username
      unityInstance.SendMessage('baseGameObject', 'SetLtiUsername', 'anonymous');
    }
  },
  OnSubmitGrade: function (grade)
  {
    submitGrade(grade);
  }
};

autoAddDeps(ltiJS, '$dependencies');
mergeInto(LibraryManager.library, ltiJS);
