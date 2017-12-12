class GetNewAccountHandler(web.RequertHandler):
    def get(self):
        data=self.get_argument('data')
        print(data)