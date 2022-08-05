import React from 'react'

export default function LineMemberTable(props) {

    const rendNames = (pNames) => {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {pNames.map(name =>
                        <tr key={name.name}>
                            <td>{name.name}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    };

    const rendContent = () => {
        let content = props.lineMembers.length < 1
            ? <p><em>Loading...</em></p>
            : rendNames(props.lineMembers);
        return (content);
    }

    return (
            <div>
                <h1>{props.lineName}</h1>
                {rendContent()}
            </div>
        );
}