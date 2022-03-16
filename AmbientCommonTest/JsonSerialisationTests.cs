using AmbientCommon.Data.Export;
using AmbientCommon.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace AmbientCommonTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void JsonSerialisationAmbientActionEnumAsValue()
        {

            var list = new List<AmbientAction>();

            for (int i = 0; i < 10; i++)
            {
                var action = ObjectFactory.GetRandomAmbientAction(i);
                list.Add(action);
            }

            var result = ExportImport.GetExportableCollectionAsJSONString(list);
            Assert.DoesNotThrow(delegate { ExportImport.GetExportableCollectionFromJSONString<AmbientAction>(result); }, "Serialision of Ambient JSON with Enums as value threw Exception");
        }

        [Test]
        public void JsonSerialisationAmbientActionEnumAsName()
        {

            var list = new List<AmbientAction>();

            for (int i = 0; i < 10; i++)
            {
                var action = ObjectFactory.GetRandomAmbientAction(i);
                list.Add(action);
            }

            var result = ExportImport.GetExportableCollectionAsJSONString(list, true);
            Assert.DoesNotThrow( delegate { ExportImport.GetExportableCollectionFromJSONString<AmbientAction>(result, true); }, "Serialision of Ambient JSON with Enums as names threw Exception");
        }
    }
}