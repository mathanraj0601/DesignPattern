// See https://aka.ms/new-console-template for more information
//using AdapterPattern.Object_Based;
using AdapterPattern.Class_Based;


// Object Based
//IAdapter xMLtoJSONConverter = new XMLtoJSONConverter("data");
//xMLtoJSONConverter.Request();

// Class Based

IAdapter adapter = new XMLtoJSONConverter("data");
adapter.Request();