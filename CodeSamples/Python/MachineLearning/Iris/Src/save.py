from modelLogic import *

#Saving a model

model.save("iris_save")

#Loading a Model
loaded_model = keras.models.load_model("iris_save")

#Print Model Summary
loaded_model.summary()