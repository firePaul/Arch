using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using UnityEngine;

namespace Asteroids.Adapter
{
    public class OdinInspectorDict : SerializedMonoBehaviour
    {
        [InfoBox("Вывод словаря в инспектор при помощи Odin")]
        public Dictionary<int, Material> IntMaterialLookup;

        public Dictionary<string, string> StringStringDictionary;

        [DictionaryDrawerSettings(KeyLabel = "Custom Key Name", ValueLabel = "Custom Value Label")]
        public Dictionary<SomeEnum, MyCustomType> CustomLabels = new Dictionary<SomeEnum, MyCustomType>()
        {
            { SomeEnum.First, new MyCustomType() },
            { SomeEnum.Second, new MyCustomType() },
        };

        [DictionaryDrawerSettings(DisplayMode = DictionaryDisplayOptions.ExpandedFoldout)]
        public Dictionary<string, List<int>> StringListDictionary = new Dictionary<string, List<int>>()
        {
            { "Numbers", new List<int>(){ 1, 2, 3, 4, } },
        };

        [DictionaryDrawerSettings(DisplayMode = DictionaryDisplayOptions.Foldout)]
        public Dictionary<SomeEnum, MyCustomType> EnumObjectLookup = new Dictionary<SomeEnum, MyCustomType>()
        {
            { SomeEnum.Third, new MyCustomType() },
            { SomeEnum.Fourth, new MyCustomType() },
        };

        [InlineProperty(LabelWidth = 90)]
        public struct MyCustomType
        {
            public int SomeMember;
            public GameObject SomePrefab;
        }

        public enum SomeEnum
        {
            First, Second, Third, Fourth
        }


        [OnInspectorInit]
        private void CreateData()
        {
            IntMaterialLookup = new Dictionary<int, Material>()
            {
                { 10, ExampleHelper.GetMaterial() },
                { 15, ExampleHelper.GetMaterial() },
            };

            StringStringDictionary = new Dictionary<string, string>()
            {
                { "Ten", ExampleHelper.GetString() },
                { "Fifteen", ExampleHelper.GetString() },
            };
        }

    }
}