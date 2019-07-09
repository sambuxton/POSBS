import urllib.request
import urllib.response
import sys
import os, glob
import tika
from tika import parser
import http.client, urllib
import json
import re
tika.initVM()


with open('SampleTextJSON.json') as json_file:  
    data = json.load(json_file)


accessKey = '456c8198f5e848c4ade149b774bab71d'
url = 'https://westus2.api.cognitive.microsoft.com'
path = '/text/analytics/v2.1/entities'


def TextAnalytics(documents):
    headers = {'Ocp-Apim-Subscription-Key': accessKey}
    conn = http.client.HTTPSConnection(url)
    body = json.dumps (documents)
    conn.request ("POST", path, body, headers)
    response = conn.getresponse ()
    return response.read ()



result = TextAnalytics (data)
print (json.dumps(json.loads(result), indent=4))




