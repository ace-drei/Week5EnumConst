# Week5EnumConst

Exercise: 
Implement a Money structure which stores an amount of money and the currency unit for that amount. Currency units should be euro or US dollar or yen. Use auto-implemented properties. Add a non-default constructor allowing the amount and the currency unit to be specified at the time of construction of an object.
Implement a method in the structure which allows the currency amount to be converted into an amount in a different currency and returned. Store the various conversion rates to be used in the conversion as constants in the structure.
Implement a method which allows 2 Money objects to be added together. The first Money object determines the currency unit for the result e.g. euro + dollar = euro. Convert currencies if necessary in this method.
