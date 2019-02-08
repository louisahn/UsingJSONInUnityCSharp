using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSonFactory
{
    class JSonAssembly
    {
        private static Dictionary<int, string> _resourceList = new Dictionary<int, string>
        {
            {1, "/Resources/dialogue.json" }
        };

        public static NarrativeEvent RunJSonFactory4Scene (int sceneNum)
        {
            string resourcePath = Path4Scene(sceneNum);
            Debug.LogFormat("sceneNum: {0}", sceneNum);


            if (IsValidJSon(resourcePath))
            {
                Debug.Log(Application.dataPath + resourcePath);

                string jsonString = File.ReadAllText(Application.dataPath + resourcePath);

                NarrativeEvent nevent = JsonConvert.DeserializeObject<NarrativeEvent>(jsonString);
                return nevent;
            }
            else
                throw new Exception("JSon file is not valid");
        }
        private static string Path4Scene(int sceneNum)
        {
            Debug.Log(_resourceList[sceneNum]);

            string resoucePathResult;
            if (_resourceList.TryGetValue(sceneNum, out resoucePathResult) )
                return _resourceList[sceneNum];
            else
                throw new Exception("The scene number does not exist");

            
        }
        private static bool IsValidJSon(string path)
        {
            Debug.LogFormat("IsValidJSon: {0}", Path.GetExtension(path));

            return (Path.GetExtension(path) == ".json") ? true : false;
        }
    }
}

