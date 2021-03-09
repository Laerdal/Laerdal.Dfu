<a name='assembly'></a>
# Laerdal.Dfu

## Contents

- [BindableObject](#T-Laerdal-Dfu-Helpers-BindableObject 'Laerdal.Dfu.Helpers.BindableObject')
  - [GetValue\`\`1(propertySelector)](#M-Laerdal-Dfu-Helpers-BindableObject-GetValue``1-System-Linq-Expressions-Expression{System-Func{``0}}- 'Laerdal.Dfu.Helpers.BindableObject.GetValue``1(System.Linq.Expressions.Expression{System.Func{``0}})')
  - [GetValue\`\`1(propertyName,defaultValue)](#M-Laerdal-Dfu-Helpers-BindableObject-GetValue``1-``0,System-String- 'Laerdal.Dfu.Helpers.BindableObject.GetValue``1(``0,System.String)')
  - [RaisePropertyChanged(propertyName)](#M-Laerdal-Dfu-Helpers-BindableObject-RaisePropertyChanged-System-String- 'Laerdal.Dfu.Helpers.BindableObject.RaisePropertyChanged(System.String)')
  - [SetProperty\`\`1(storage,value,propertyName)](#M-Laerdal-Dfu-Helpers-BindableObject-SetProperty``1-``0@,``0,System-String- 'Laerdal.Dfu.Helpers.BindableObject.SetProperty``1(``0@,``0,System.String)')
  - [SetValue\`\`1(propertySelector,value)](#M-Laerdal-Dfu-Helpers-BindableObject-SetValue``1-System-Linq-Expressions-Expression{System-Func{``0}},``0- 'Laerdal.Dfu.Helpers.BindableObject.SetValue``1(System.Linq.Expressions.Expression{System.Func{``0}},``0)')
  - [SetValue\`\`1(value,propertyName)](#M-Laerdal-Dfu-Helpers-BindableObject-SetValue``1-``0,System-String- 'Laerdal.Dfu.Helpers.BindableObject.SetValue``1(``0,System.String)')
  - [SetValue\`\`1(propertyName,value)](#M-Laerdal-Dfu-Helpers-BindableObject-SetValue``1-System-String,``0- 'Laerdal.Dfu.Helpers.BindableObject.SetValue``1(System.String,``0)')

<a name='T-Laerdal-Dfu-Helpers-BindableObject'></a>
## BindableObject `type`

##### Namespace

Laerdal.Dfu.Helpers

<a name='M-Laerdal-Dfu-Helpers-BindableObject-GetValue``1-System-Linq-Expressions-Expression{System-Func{``0}}-'></a>
### GetValue\`\`1(propertySelector) `method`

##### Summary

Gets the value of a property.

##### Returns

The value of the property or default value if not exist.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertySelector | [System.Linq.Expressions.Expression{System.Func{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0}}') | Expression tree contains the property definition. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the property value. |

<a name='M-Laerdal-Dfu-Helpers-BindableObject-GetValue``1-``0,System-String-'></a>
### GetValue\`\`1(propertyName,defaultValue) `method`

##### Summary

Gets the value of a property.

##### Returns

The value of the property or default value if not exist.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [\`\`0](#T-``0 '``0') | The name of the property. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the property value. |

<a name='M-Laerdal-Dfu-Helpers-BindableObject-RaisePropertyChanged-System-String-'></a>
### RaisePropertyChanged(propertyName) `method`

##### Summary

Raises the PropertyChanged event for the given property

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Laerdal-Dfu-Helpers-BindableObject-SetProperty``1-``0@,``0,System-String-'></a>
### SetProperty\`\`1(storage,value,propertyName) `method`

##### Summary

Sets the value of a property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| storage | [\`\`0@](#T-``0@ '``0@') | Reference variable to store it in. |
| value | [\`\`0](#T-``0 '``0') | The property value. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the property |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the property value. |

<a name='M-Laerdal-Dfu-Helpers-BindableObject-SetValue``1-System-Linq-Expressions-Expression{System-Func{``0}},``0-'></a>
### SetValue\`\`1(propertySelector,value) `method`

##### Summary

Sets the value of a property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertySelector | [System.Linq.Expressions.Expression{System.Func{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0}}') | Expression tree contains the property definition. |
| value | [\`\`0](#T-``0 '``0') | The property value. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the property value. |

<a name='M-Laerdal-Dfu-Helpers-BindableObject-SetValue``1-``0,System-String-'></a>
### SetValue\`\`1(value,propertyName) `method`

##### Summary

Sets the value of a property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The property value. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the property value. |

<a name='M-Laerdal-Dfu-Helpers-BindableObject-SetValue``1-System-String,``0-'></a>
### SetValue\`\`1(propertyName,value) `method`

##### Summary

Sets the value of a property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property. |
| value | [\`\`0](#T-``0 '``0') | The property value. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the property value. |
