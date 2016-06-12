import superagent from 'superagent';
import configs from '../configs';
import baseStorage from './baseStorage';

const methods = ['get', 'post', 'put', 'patch', 'del'];

const storage = baseStorage.getStorage(configs.storage);

function formatUrl(path) {
  let adjustedPath = path[0] !== '/' ? '/' + path : path;
  adjustedPath = configs.virtualPath + configs.apiRoot + adjustedPath;
  return adjustedPath;
}

class _ApiClient {
  constructor(req) {
    methods.forEach((method) =>
      this[method] = (path, { params, data, formEncoding, token, save, clear} = {}) => new Promise((resolve, reject) => {
        const request = superagent[method](formatUrl(path));
        if (formEncoding) {
          request.set('Content-Type', 'application/x-www-form-urlencoded');
        }
        if (token) {
          let bearerToken = sessionStorage.get(configs.authToken).access_token;
          request.set('Authorization', 'Bearer ' + bearerToken)
        }
        if (params) {
          request.query(params);
        }
        if (data) {
          request.send(data);
        }
        if (save) {
          const { key, expired }=save;
          storage.retrieve(key, expired, (body)=> {
            resolve(body)
          }, (saveCallback, saveOption)=> {
            request.end((err, { body } = {}) => {
              if (err) reject(body || err);
              saveCallback(body, saveOption);
              resolve(body)
            })
          });
        } else {
          request.end((err, { body } = {}) => {
            if (err) reject(body || err);
            if (clear) {
              storage.remove(clear.key);
            }
            resolve(body)
          });
        }
      }));
  }
}

const ApiClient = _ApiClient;

export default ApiClient;
