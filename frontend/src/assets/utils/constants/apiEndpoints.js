const baseUrl = "http://localhost:5001/api";

const apiEndpoints = {
    auth: {
        login: `${baseUrl}/`,
        register: `${baseUrl}/`,
        recovery: `${baseUrl}/`
    },
    crud: {
        product: {
            getAll: `${baseUrl}/`,
            createNew: `${baseUrl}/`,
            getByPaginated: `${baseUrl}/`,
            getById: `${baseUrl}/`,
            updateById: `${baseUrl}/`,
            removeById: `${baseUrl}/`
        },
        category: {
            getAll: `${baseUrl}/`,
            createNew: `${baseUrl}/`,
            getByPaginated: `${baseUrl}/`,
            getById: `${baseUrl}/`,
            updateById: `${baseUrl}/`,
            removeById: `${baseUrl}/`
        },
        brand: {
            getAll: `${baseUrl}/`,
            createNew: `${baseUrl}/`,
            getByPaginated: `${baseUrl}/`,
            getById: `${baseUrl}/`,
            updateById: `${baseUrl}/`,
            removeById: `${baseUrl}/`
        }
    }
};

export default apiEndpoints;
