#!/usr/bin/python3
import pandas as pd
import joblib
import sys

dict = {
    1: "DroidDream",
    2: "Sandroid",
    3: "Rootsmart",
    4: "Wroba",
    5: "Nickyspy",
    6: "Bmaster",
    7: "NotCompatible",
    8: "Geinimi",
    9: "Anserverbot",
    10: "Zitmo",
    11: "Pletor",
    12: "MisoSMS",
    13: "TigerBot",
    14: "PJapps"
}


def classify(file_path, file_name):
    data_list = pd.read_csv(file_path)

    loaded_model = joblib.load(file_name)
    number = loaded_model.predict(data_list)[0]
    print("Данный зловред принадлежит семейству %s" % (dict[number]))


if __name__ == '__main__':
    file_name, st = sys.argv[1], sys.argv[2]
    classify(st, file_name)
