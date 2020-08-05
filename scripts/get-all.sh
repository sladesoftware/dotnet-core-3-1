#!/bin/bash

curl -kL localhost:5000/api/todo -XGET -w '\n' | jq .

