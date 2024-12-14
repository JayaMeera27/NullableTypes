**Nullable Types**

Value types are by default non-nullable types.(data type which doesn’t support null values)

Reference Types are by default nullable types.(data type which supports null value)

Converting non-nullable value types to Nullable types

Nullable<int> x=null or int? x=null
    
__Null coalescing operator__

    * The 'null coalescing operator' checks whether the value is null or not.
    * It returns the left-hand-side operand if the value is not null.
    * It returns the right-hand-side operand if the value is null.
    
__Null Propagation Operator__

    * The "Null Propagation Operator ( ?. ) and ( ? [] ) checks the value of left-hand operand whether it is null or not.
    * It returns the right-hand-side operand (property or method), if the value is not null.
    * It returns null, if the value is null.

